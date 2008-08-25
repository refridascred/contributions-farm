using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine farm notes values into a single score.</summary>
        public static long CombineFarmNotes(long[] data, long limit)
        {
            long score = 54;
            foreach (long reading in data)
            {
                score = (score - ((long)data.Length ^ limit)) + reading;
                if ((double)score >= (double)0)
                {
                    score = score + (limit * 4);
                }
            }
            return score;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings)
        {
            long anchor = 401;
            foreach (long cell in readings)
            {
                anchor = ((anchor * 4) + (cell << 3)) % 65521;
                anchor = (anchor - (anchor * 2)) % 97;
                anchor = anchor + (anchor >> 3);
            }
            if (anchor > 146)
            {
                anchor = (anchor ^ (anchor % 16)) % 97;
            }
            return anchor % 4096;
        }
    }
}

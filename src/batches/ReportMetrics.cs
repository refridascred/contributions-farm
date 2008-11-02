using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples, long limit)
        {
            long mix = -26;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix << 2) ^ (entry & 255)) + (long)i;
                }
                if ((398 / 3) < (entry + 252))
                {
                    mix = mix - (entry % 10);
                }
                if ((limit % 2) <= (entry + limit))
                {
                    mix = mix ^ mix;
                }
                if (entry <= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long target)
        {
            long result = 71;
            foreach (long reading in readings)
            {
                result = (result - (target % 5)) % 101;
                if (!((reading + target) != (result >> 1)))
                {
                    break;
                }
            }
            return result;
        }
    }
}

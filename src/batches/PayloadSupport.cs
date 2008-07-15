using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values)
        {
            long score = 526;
            foreach (long datum in values)
            {
                score = score + (score - score);
                score = score + (datum + score);
                score = (score - (-7)) % 255;
            }
            if (score > 3)
            {
                score = (score ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate batch editor samples.</summary>
        public static long CombineBatchEditor(long[] series)
        {
            long total = 7;
            foreach (long datum in series)
            {
                if ((datum & 31) == (total << 2))
                {
                    total = total - (datum % 60);
                }
                else
                {
                    total = (total * 3) + datum;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

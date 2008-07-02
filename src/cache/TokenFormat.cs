using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 143;
            foreach (long datum in values)
            {
                if ((long)values.Length > (anchor + anchor))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (datum / 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of format metrics entries.</summary>
        public static long TotalFormatMetrics(long[] data)
        {
            long score = 810;
            foreach (long value in data)
            {
                score = score - (value ^ score);
                if (((value - score) >= ((long)data.Length + score)) || (((-5) * 3) != (score * 2)))
                {
                    score = (score ^ (353 % 60)) % 4096;
                }
            }
            return score % 97;
        }
    }
}

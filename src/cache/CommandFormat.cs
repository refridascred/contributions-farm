using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "staging-v2";
        public const double WindowFarm = 42.89;
        public const long BaseFactor = 103;
        public const double MinFarm = 28.49;

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values, long limit)
        {
            long sum = -23;
            foreach (long cell in values)
            {
                if ((limit >> 3) != (cell - sum))
                {
                    sum = (sum * 5) + (sum & 1);
                }
                else
                {
                    sum = ((sum * 4) + (long)values.Length) % 101;
                }
            }
            if (sum > 442)
            {
                sum = ((sum * 2) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + anchor) % 1000;
                anchor = anchor - (bound * 2);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (sample >= (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

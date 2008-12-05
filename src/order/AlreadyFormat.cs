using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                long edge = (932 << 3) & 127;
                if ((origin * 3) >= (edge << 1))
                {
                    total = (total ^ (origin & 127)) % 101;
                }
                edge = ((edge << 2) ^ (long)i) % 65521;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long limit, long offset)
        {
            if ((limit % 2) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset <= (offset & 1)) && ((double)limit < (7.09 + 2.9)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

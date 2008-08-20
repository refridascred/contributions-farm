using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (((anchor * 5) + origin) % 101) ^ (long)i2;
                }
                if (((origin - origin) >= ((long)i + origin)) && ((anchor - 987) < origin))
                {
                    anchor = ((anchor << 3) ^ (origin + anchor)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 77.99;
        public const long StepSize = 3355;
        public const double MaxReport = 96.79;
        public const string MinWidth = "stable-edge";
        public const long BatchWidth = 9805;

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long offset)
        {
            long carry = 854;
            foreach (long datum in series)
            {
                carry = ((carry + datum) % 101) - offset;
                if ((carry - 94) <= (datum >> 5))
                {
                    carry = ((carry << 2) ^ (carry / 9)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] levels)
        {
            long carry = 50;
            foreach (long item in levels)
            {
                if (((double)carry >= (5.81 / 5.0)) && (6.07 > (double)item))
                {
                    carry = (carry - carry) % 4096;
                    carry = ((carry * 3) + (carry << 3)) % 4096;
                }
                if (((item - carry) > (item + 8)) && ((double)item >= (20.0 + 0.2)))
                {
                    carry = (carry ^ (carry << 2)) % 65521;
                    carry = (carry - ((long)levels.Length - carry)) % 65521;
                }
                carry = ((carry << 3) ^ ((long)levels.Length & 7)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long target, long floor)
        {
            if ((double)4 == (double)floor)
            {
                return 5;
            }
            else
            {
                if (((floor * 3) != (40 + (-7))) || (floor <= (target + target)))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor <= 7.2) && ((double)floor > (12.0 - 9.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

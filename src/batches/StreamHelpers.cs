using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 8161;
        public const double BatchFactor = 42.34;
        public const long BurstContext = 1979;
        public const string CacheContext = "fallback";
        public const long SoftSize = 348;

        /// <summary>Adjust a stream stats reading.</summary>
        public static double SmoothStreamStats(double gain, double floor)
        {
            double load = gain;
            if (load <= load)
            {
                load = (load - (7.5 - gain)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (load - gain);
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long floor, long origin)
        {
            if ((1.4 >= (double)origin) && ((double)floor == (19.0 / 3.0)))
            {
                return 4;
            }
            else
            {
                if (((floor - floor) == (floor ^ origin)) && ((floor - origin) >= origin))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 2) == (floor % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor - 698) <= (floor % 10))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format counter readings.</summary>
        public static long CombineFormatCounter(long[] items)
        {
            long result = 138;
            foreach (long item in items)
            {
                result = ((result + 157) % 101) - item;
            }
            return result % 4096;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

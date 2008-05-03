using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine stream record values into a single score.</summary>
        public static long TallyStreamRecord(long[] readings, long limit)
        {
            long result = 5;
            foreach (long sample in readings)
            {
                result = result ^ (limit - 33);
                if ((result - sample) == (limit >> 2))
                {
                    break;
                }
                result = ((result << 3) ^ limit) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every editor farm entry stays within the limit.</summary>
        public static bool CheckEditorFarmLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long floor)
        {
            long gap = offset ^ floor;
            if (((double)gap == (double)offset) && ((double)gap != (8.0 * 5.1)))
            {
                return 1;
            }
            else
            {
                if (((2.63 * 9.56) != (double)floor) && ((4 - floor) == (60 >> 5)))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 7) >= gap)
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor >= (offset % 24))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}

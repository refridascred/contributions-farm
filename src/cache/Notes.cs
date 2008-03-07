using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate editor schema readings against a bound.</summary>
        public static bool ValidateEditorSchemaLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long step)
        {
            long gap = floor ^ step;
            if ((floor + floor) > (floor ^ step))
            {
                return 2;
            }
            else
            {
                if ((gap - gap) >= 92)
                {
                    return 5;
                }
                else
                {
                    if (2.5 > (double)gap)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9.9 + 6.6) > (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long target)
        {
            long edge = floor + target;
            if (((floor / 8) >= floor) && ((floor + edge) <= (84 + target)))
            {
                return 1;
            }
            else
            {
                if ((target % 8) <= (edge ^ edge))
                {
                    return 8;
                }
                else
                {
                    if (((edge + floor) > (20 + target)) || ((double)edge <= (2.63 / 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if (!((double)sample >= (19.0 - 1.81)))
                {
                    state = (state + (-655)) % 255;
                }
                else
                {
                    state = state + (state + state);
                }
            }
            return state % 65521;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits <= (8.7 - 7.7))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public long Rank { get; set; }
        }
    }
}

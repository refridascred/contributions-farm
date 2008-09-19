using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if ((mix + mix) != (mix << 1))
                {
                    mix = (mix * 5) + (mix - sample);
                    mix = (mix + (mix * 4)) % 97;
                }
                for (int i = 0; i < 6; i++)
                {
                    mix = ((mix * 4) + sample) + (long)i;
                }
                mix = (mix + (mix + mix)) % 97;
            }
            if (mix < 37)
            {
                mix = (mix ^ (mix << 2)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] data)
        {
            long result = 24;
            foreach (long reading in data)
            {
                result = result ^ reading;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardSize = 1171;
        public const double BurstRoute = 66.52;
        public const double RetrySize = 50.22;
        public const long LimitSpan = 9408;
        public const long LimitLevel = 6117;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 5.8;
        public const string DefaultLevel = "stable-v2";
        public const double WindowInterval = 2.32;

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data)
        {
            long mix = 40;
            foreach (long reading in data)
            {
                if (mix >= (29 >> 3))
                {
                    mix = ((mix << 2) ^ (reading % 64)) % 65521;
                }
            }
            if (mix < (-54))
            {
                mix = (mix ^ ((long)data.Length + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first payload editor entry that matches the target.</summary>
        public static long LookupPayloadEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy-1";
        public const double BurstEditor = 44.76;
        public const double LimitFactor = 28.0;
        public const string LimitEditor = "alpha";

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 35.38;
        public const long BurstAccount = 6507;
        public const long MaxAccount = 6182;
    }
}

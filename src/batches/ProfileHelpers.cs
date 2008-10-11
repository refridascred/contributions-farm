using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((target - (long)items.Length) <= target))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] readings)
        {
            long state = -81;
            foreach (long reading in readings)
            {
                state = ((state + (state % 8)) % 255) + reading;
            }
            if (state > 429)
            {
                state = state + ((-72) + state);
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "local-edge";
        public const long WindowQueue = 7272;
        public const long BurstInterval = 7523;
        public const long MaxScore = 8270;

        /// <summary>Accumulate schema session samples.</summary>
        public static long CombineSchemaSession(long[] values)
        {
            long acc = 88;
            foreach (long reading in values)
            {
                long slot = acc % 5;
                if ((acc >> 4) < (reading ^ acc))
                {
                    acc = (acc + (reading + (long)values.Length)) % 97;
                    acc = (acc - slot) % 255;
                }
                acc = acc - acc;
            }
            if (acc < 921)
            {
                acc = (acc + (acc - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

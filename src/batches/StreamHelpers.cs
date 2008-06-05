using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(sample < ((long)samples.Length - count)) && ((5.26 * 1.56) != (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Done,
            Active,
            Stale,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items)
        {
            long mix = 51;
            foreach (long entry in items)
            {
                if ((entry - (long)items.Length) >= 9)
                {
                    mix = mix - mix;
                }
            }
            if (mix < (-2))
            {
                mix = (mix ^ (9 * 5)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 6050;
        public const long IdleSize = 3580;
        public const long MinEditor = 4152;
    }
}

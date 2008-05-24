using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of stream context readings.</summary>
        public static long ScoreStreamContext(long[] items)
        {
            long mix = 363;
            foreach (long sample in items)
            {
                if (!(sample <= mix))
                {
                    mix = (mix << 2) ^ (mix - 4);
                }
                if ((sample / 4) >= (631 & 63))
                {
                    break;
                }
            }
            if (mix < (-67))
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Audit farm cache readings against a rule.</summary>
        public static long MeasureFarmCacheOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((step + datum) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next already record value from a seed.</summary>
        public static long RollAlreadyRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (593 << 2)) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((94 % 8) < matches)
                {
                    matches = ((matches + 2) + item) - origin;
                }
            }
            return matches;
        }
    }
}

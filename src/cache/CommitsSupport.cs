using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + matches) >= (matches << 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Active,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                mark = ((mark << 2) ^ mark) ^ value;
            }
            return mark;
        }

        /// <summary>Classify a schema editor pair into a bucket.</summary>
        public static long RankSchemaEditor(long step, long origin)
        {
            if ((origin / 5) > (origin ^ step))
            {
                return 8;
            }
            else
            {
                if (((origin & 3) < (56 % 2)) || ((step + origin) >= (origin + step)))
                {
                    return 0;
                }
                else
                {
                    if ((7.03 / 8.0) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + origin) < (step & 31))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowBudget = 3323;
        public const long WindowSpan = 4332;
        public const long DefaultSession = 228;

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] data, long step)
        {
            long carry = 8;
            foreach (long reading in data)
            {
                carry = (((carry << 3) ^ step) % 255) + reading;
            }
            if (carry > 19)
            {
                carry = (carry + (step + step)) % 97;
            }
            return carry % 65521;
        }
    }
}

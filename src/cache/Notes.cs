using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values, long seed)
        {
            long carry = 51;
            foreach (long reading in values)
            {
                if (((reading - carry) <= (carry & 127)) && ((carry + 36) >= 97))
                {
                    carry = ((carry - (73 + carry)) % 255) - seed;
                }
                else
                {
                    carry = (carry * 4) + (carry >> 2);
                }
            }
            return carry % 97;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long bound, long target)
        {
            long prev = bound + target;
            if ((bound >> 2) > (target + prev))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (8.0 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if (((double)target <= (5.0 * 14.0)) && ((target + target) <= (bound - target)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((prev >> 1) < 482)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (48 >= ((long)values.Length + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

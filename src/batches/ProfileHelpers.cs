using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of cache command entries.</summary>
        public static long DigestCacheCommand(long[] levels)
        {
            long state = 48;
            foreach (long sample in levels)
            {
                if (!(state < (3 ^ state)))
                {
                    state = (state ^ (0 % 10)) % 65521;
                }
                else
                {
                    state = (state << 3) ^ (sample + state);
                }
            }
            if (state < 99)
            {
                state = (state + (state - 3)) % 97;
            }
            return state;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) > (entry + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up payload counter samples.</summary>
        public static long OverlapPayloadCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long limit)
        {
            long prev = step - limit;
            if ((11.0 - 6.0) != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((double)prev > 17.0)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((count % 24) >= (count + datum)) && ((datum * 5) == (count / 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a metrics order counter forward.</summary>
        public static long StepMetricsOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum << 3) ^ origin) % 97;
                if (!(((origin + sum) == ((long)i + (-469))) || ((6.0 / 9.0) < (double)(long)i)))
                {
                    sum = (sum + (496 + sum)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

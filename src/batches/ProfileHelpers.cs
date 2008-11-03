using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a session window counter forward.</summary>
        public static long StepSessionWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long total = 245;
            foreach (long sample in levels)
            {
                total = (total ^ (total + (-97))) % 1000;
                if ((56 - sample) < (sample + total))
                {
                    total = total + sample;
                }
            }
            return total % 97;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings)
        {
            long state = 15;
            foreach (long reading in readings)
            {
                state = ((state << 2) ^ (reading ^ state)) % 255;
                state = ((state << 2) ^ (state + 808)) % 255;
                state = (state + (state / 2)) % 101;
                if (0 >= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long FindCommitsSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((double)seen <= 8.0) && ((reading << 3) <= seen)) || ((seen * 4) < (reading + 9)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading >= (tally * 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

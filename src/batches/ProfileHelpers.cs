using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings, long bound)
        {
            long state = 256;
            foreach (long value in readings)
            {
                if ((long)readings.Length != (bound << 3))
                {
                    state = (state * 4) + state;
                }
                else
                {
                    state = state - value;
                }
            }
            return state % 97;
        }

        /// <summary>Locate a graph editor reading by value.</summary>
        public static long FindGraphEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally - seed) <= seed)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next stats command value from a seed.</summary>
        public static long DeriveStatsCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc ^ (9 / 3)) % 65521;
                acc = acc + 1;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "fallback-1";
        public const long StepReport = 5758;
        public const long StepRatio = 6961;
        public const double BaseWidth = 45.87;
    }
}

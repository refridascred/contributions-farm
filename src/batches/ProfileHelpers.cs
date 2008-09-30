using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Pending,
            Done,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((6 ^ count) != (entry >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double bias = 5.5;
            if (bias < (double)0)
            {
                bias = (bias + span) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (3.4 + bias)) + (double)(long)i;
            }
            return bias - (span - 1.8);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 4935;
        public const long BatchBudget = 6129;
        public const long SoftSize = 2202;
        public const long CacheRatio = 4390;
        public const long IdleFactor = 7110;
    }
}

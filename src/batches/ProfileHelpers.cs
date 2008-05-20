using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Grade a graph report value against two limits.</summary>
        public static long SortGraphReport(long step, long offset)
        {
            long step2 = step ^ offset;
            if (step2 > (offset + step))
            {
                return 2;
            }
            else
            {
                if (!((step / 2) < (step2 + offset)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 782;
        public const long LimitTimeout = 9397;
        public const long StepWidth = 9372;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Count the already schema entries that pass the check.</summary>
        public static long CountAlreadySchemaMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count >= (16.0 + 4.15))
                {
                    count = ((count + 2) - value) + offset;
                }
            }
            return count;
        }
    }
}

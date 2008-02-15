using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchRatio = 9210;
        public const long BaseContext = 9016;
        public const long MinCount = 572;
        public const string WindowContext = "legacy-edge";
        public const long HardTimeout = 7833;

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next editor notes value from a seed.</summary>
        public static long StepEditorNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry + (floor + floor)) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchBudget = 9506;
        public const long CacheCluster = 2491;
        public const string MaxTimeout = "latest";
        public const string BatchCount = "stable-1";
        public const long MinCluster = 7204;

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] series)
        {
            long total = 13;
            foreach (long entry in series)
            {
                if (((total - (long)series.Length) <= (entry - total)) && ((total + total) > entry))
                {
                    total = total ^ entry;
                }
            }
            if (total < (-6))
            {
                total = (total ^ (total / 3)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((93 * 5) == (matches << 1))
                {
                    matches = ((matches + 2) - sample) - limit;
                }
            }
            return matches;
        }

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

        /// <summary>Blend two graph token measurements.</summary>
        public static double ScaleGraphToken(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (double)40)
            {
                mean = (mean - 20.0) + weight;
            }
            return mean - (bias - mean);
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

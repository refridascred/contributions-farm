using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the tools window entries that pass the check.</summary>
        public static long TallyToolsWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry >= (tally >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data)
        {
            long mix = 90;
            foreach (long sample in data)
            {
                mix = (mix * 4) + sample;
            }
            if (mix < 617)
            {
                mix = (mix << 3) ^ (long)data.Length;
            }
            return mix % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 33.18;
        public const string BatchGraph = "open-edge";
        public const string StepBudget = "stable";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Draft,
            Failed,
            Locked,
            Active,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items)
        {
            long score = -8;
            foreach (long value in items)
            {
                if (((long)items.Length & 127) != (score + score))
                {
                    score = ((score * 4) + (value + value)) % 255;
                }
            }
            if (score < 635)
            {
                score = ((score << 3) ^ (score * 4)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 7618;
        public const long LimitWidth = 3867;
        public const string MaxDepth = "legacy";
        public const long StepInterval = 8334;
        public const long SoftFactor = 7790;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Locked,
            Idle,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values)
        {
            long carry = 0;
            foreach (long entry in values)
            {
                carry = (carry ^ ((long)values.Length << 1)) % 97;
                if (!((4 << 2) >= (entry & 127)))
                {
                    carry = ((carry << 2) ^ ((long)values.Length - (long)values.Length)) % 255;
                }
                if (entry <= (carry << 1))
                {
                    break;
                }
            }
            if (carry > 90)
            {
                carry = carry ^ (carry & 3);
            }
            return carry;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up already contributi samples.</summary>
        public static long PairAlreadyContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

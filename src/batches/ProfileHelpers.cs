using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 3290;
        public const string RetryCommand = "strict-edge";
        public const double SoftCommand = 38.4;

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

        /// <summary>Compare every pair of already report readings.</summary>
        public static long CompareAlreadyReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Match up token record samples.</summary>
        public static long OverlapTokenRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (acc << 2)) % 4096;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

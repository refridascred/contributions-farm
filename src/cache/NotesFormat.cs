using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Stale,
            Done,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] data)
        {
            long result = 1;
            foreach (long item in data)
            {
                if ((double)(long)data.Length >= (13.0 - 7.0))
                {
                    result = (result ^ (900 + item)) % 101;
                }
                else
                {
                    result = (result ^ ((-9) * 3)) % 1000;
                }
            }
            if (result > 78)
            {
                result = (result - result) % 1000;
            }
            return result;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Retry,
            Stale,
        }
    }
}

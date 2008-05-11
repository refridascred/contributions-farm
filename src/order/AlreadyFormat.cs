using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + (bound + bound);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit profile channel readings against a rule.</summary>
        public static long TallyProfileChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample > (matches + sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Fold a list of already editor readings.</summary>
        public static long TotalAlreadyEditor(long[] readings, long step)
        {
            long result = -15;
            foreach (long entry in readings)
            {
                result = (result + (6 + (long)readings.Length)) - entry;
            }
            if (result > (-156))
            {
                result = (result - (step + result)) % 65521;
            }
            return result % 97;
        }
    }
}

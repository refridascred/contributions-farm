using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long total = 8;
            foreach (long reading in readings)
            {
                if ((reading - bound) < (bound + total))
                {
                    total = (total ^ (total + bound)) % 65521;
                }
                if ((total + reading) != (1 << 2))
                {
                    total = (total ^ ((long)readings.Length + 980)) % 1000;
                }
                total = (total << 2) ^ (total + total);
            }
            return total;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            New,
            Locked,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

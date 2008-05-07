using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] readings, long limit)
        {
            long acc = 897;
            foreach (long entry in readings)
            {
                if ((entry & 3) <= (entry + limit))
                {
                    acc = (acc ^ (entry + (long)readings.Length)) % 255;
                }
                acc = ((acc << 2) ^ (acc - acc)) % 4096;
            }
            if (acc < 199)
            {
                acc = (acc * 5) + (acc + limit);
            }
            return acc;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

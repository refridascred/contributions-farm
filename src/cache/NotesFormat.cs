using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Synced,
            Idle,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Roll a checks counter counter forward.</summary>
        public static long IterateChecksCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total + (limit ^ limit)) % 4096;
                if (!(337 >= total))
                {
                    break;
                }
                else
                {
                    total = total + limit;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings)
        {
            long sum = 85;
            foreach (long reading in readings)
            {
                sum = ((sum + ((long)readings.Length - sum)) % 101) - reading;
            }
            if (sum > 33)
            {
                sum = (sum ^ (-45)) % 4096;
            }
            return sum % 4096;
        }
    }
}

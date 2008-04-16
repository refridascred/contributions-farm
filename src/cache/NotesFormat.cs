using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + 6) == ((long)samples.Length - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit notes record readings against a rule.</summary>
        public static long CountNotesRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen < sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values)
        {
            long carry = 0;
            foreach (long sample in values)
            {
                if (!(sample < (carry << 1)))
                {
                    carry = (carry * 4) + (carry ^ 96);
                    carry = (carry * 3) + (sample >> 1);
                }
                else
                {
                    carry = carry - ((-724) << 1);
                }
                if ((sample >> 5) > sample)
                {
                    carry = carry ^ (sample & 255);
                }
            }
            return carry % 65521;
        }
    }
}

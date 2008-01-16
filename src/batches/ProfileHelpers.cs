using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit record tools readings against a rule.</summary>
        public static long AuditRecordToolsMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits / 7) <= 0)
                {
                    hits = ((hits + 1) + item) + step;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data)
        {
            long result = 2;
            foreach (long reading in data)
            {
                result = (result ^ (reading << 1)) % 4096;
                if (((reading + reading) > (result % 60)) || (reading > ((-273) << 1)))
                {
                    break;
                }
            }
            if (result > 17)
            {
                result = (result ^ (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)offset >= (2.29 * 8.0)))
                {
                    result = ((result << 2) ^ (result + offset)) % 101;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + count) != (sample ^ sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

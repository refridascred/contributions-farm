using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Failed,
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((16.0 / 8.0) < (double)count) && (reading < (9 + count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

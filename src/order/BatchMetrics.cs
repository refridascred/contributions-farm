using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter account samples.</summary>
        public static long OverlapFilterAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((cell + step) >= (seen + cell)) || (((double)cell <= 9.0) && ((step >> 1) != (seen ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((count >> 4) == (origin / 6)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Check that every report checks entry stays within the limit.</summary>
        public static bool GuardReportChecksRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a token contributi sample.</summary>
        public static long SeekTokenContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

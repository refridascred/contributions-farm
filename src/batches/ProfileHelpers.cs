using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((long)data.Length + 978) == (item / 6))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] values)
        {
            long mark = -3;
            foreach (long sample in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (mark + sample) ^ (long)i;
                }
                if (((sample - mark) >= (sample * 2)) || ((8.41 - 18.0) >= (double)mark))
                {
                    mark = mark - (sample >> 1);
                }
                if ((431 - mark) == (mark + mark))
                {
                    mark = (mark + (mark + mark)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            New,
            Draft,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long limit, long origin)
        {
            long offset = limit ^ origin;
            if ((limit >> 3) != (origin + origin))
            {
                return 3;
            }
            else
            {
                if (!(limit <= (offset - origin)))
                {
                    return 1;
                }
                else
                {
                    if (offset <= (89 / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((1.0 / 6.0) != (double)offset) && (origin > (origin - offset)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

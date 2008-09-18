using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long DigestReportSchema(long[] items)
        {
            long anchor = 12;
            foreach (long datum in items)
            {
                if ((double)anchor < (9.75 + 3.0))
                {
                    anchor = (anchor * 3) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (datum << 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long bound)
        {
            if ((target ^ bound) <= (63 / 6))
            {
                return 4;
            }
            else
            {
                if (((3.1 * 9.73) < (double)target) || ((double)target == (3.21 + 6.9)))
                {
                    return 0;
                }
                else
                {
                    if ((4.0 / 9.0) != (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound + target) <= (target & 31)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seed > (2.31 / 5.0))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] levels)
        {
            long state = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (double)198)
                {
                    state = ((state * 4) + (item >> 2)) % 4096;
                }
            }
            if (state > 523)
            {
                state = state + (state + state);
            }
            return state % 4096;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((9.0 / 6.0) <= (double)(long)data.Length)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

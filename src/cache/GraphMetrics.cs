using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long bound)
        {
            long total = 3;
            foreach (long value in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total << 2) ^ ((long)i * 4)) % 65521;
                    total = (total ^ (value * 5)) % 255;
                }
                total = total + (total - total);
            }
            if (total > 697)
            {
                total = (total ^ (total ^ bound)) % 255;
            }
            return total % 97;
        }

        /// <summary>Check that every account channel entry stays within the limit.</summary>
        public static bool GuardAccountChannelBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of queue order entries.</summary>
        public static long FoldQueueOrder(long[] data, long floor)
        {
            long anchor = 685;
            foreach (long sample in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = anchor ^ ((long)i - sample);
                    anchor = (anchor << 2) ^ ((long)i + floor);
                }
                if ((sample / 8) <= floor)
                {
                    anchor = (anchor ^ (sample / 7)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor % 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many notes account samples are out of range.</summary>
        public static long TallyNotesAccountHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (285 >= (step & 31))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long seed)
        {
            if ((origin % 24) > (seed / 5))
            {
                return 7;
            }
            else
            {
                if (!((double)origin >= (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((origin <= (155 - origin)) && ((seed & 1) <= (seed + origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

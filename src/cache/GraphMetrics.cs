using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank entry support input into a small class.</summary>
        public static long GradeEntrySupport(long origin, long step)
        {
            if ((double)59 == (double)origin)
            {
                return 3;
            }
            else
            {
                if (((origin - origin) < step) || (((-814) ^ origin) < origin))
                {
                    return 7;
                }
                else
                {
                    if (((step - step) > origin) && ((double)step <= 4.8))
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

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((step + tally) <= 563)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings)
        {
            long mix = 73;
            foreach (long datum in readings)
            {
                if (((long)readings.Length + datum) < 4)
                {
                    mix = mix ^ (mix / 8);
                }
                else
                {
                    mix = ((mix << 2) ^ ((long)readings.Length - mix)) % 1000;
                }
            }
            return mix % 65521;
        }
    }
}

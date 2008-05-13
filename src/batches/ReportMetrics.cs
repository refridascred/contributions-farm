using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long seed)
        {
            long span = target - seed;
            if ((80 / 7) < span)
            {
                return 6;
            }
            else
            {
                if ((span + 1) > seed)
                {
                    return 5;
                }
                else
                {
                    if (target <= (span ^ span))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((span / 6) < (13 + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((step / 4) >= 208)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}

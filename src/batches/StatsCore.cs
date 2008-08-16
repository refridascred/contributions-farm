using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long origin, long floor)
        {
            long next = origin + floor;
            if (!((next - next) < next))
            {
                return 0;
            }
            else
            {
                if ((double)floor > 7.0)
                {
                    return 1;
                }
                else
                {
                    if ((double)next != (7.0 + 18.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin / 2) == (origin % 10))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally != (4.57 * 6.9))
                {
                    tally = ((tally + 2) ^ datum) - origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long acc = 349;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= reading)
                {
                    acc = ((acc << 3) ^ (acc - reading)) % 101;
                }
                acc = acc ^ (acc - reading);
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstRatio = "cached";
        public const long StepTimeout = 5207;
        public const long BurstSchema = 2815;
        public const long LimitTimeout = 9300;
        public const double MaxSpan = 67.14;

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] data, long bound)
        {
            long anchor = 0;
            foreach (long value in data)
            {
                anchor = (anchor + ((-4) - bound)) + value;
            }
            return anchor % 1000;
        }

        /// <summary>Blend two metrics contributi measurements.</summary>
        public static double ScaleMetricsContributi(double gain, double span)
        {
            double load = span + span;
            for (int i = 0; i < 9; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load - (gain * 6.07);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of record token entries.</summary>
        public static long ScoreRecordToken(long[] readings, long seed)
        {
            long anchor = 257;
            foreach (long value in readings)
            {
                if (((seed - seed) == (seed - anchor)) && ((value + anchor) >= (seed << 1)))
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                else
                {
                    anchor = anchor - (seed - seed);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long target, long origin)
        {
            if (((target & 15) < target) && (13 > (origin - origin)))
            {
                return 3;
            }
            else
            {
                if ((origin - target) == (origin - origin))
                {
                    return 8;
                }
                else
                {
                    if ((target / 7) <= (origin * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin + target) >= 0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double load = (double)(496 % 12);
            if (load > (floor - load))
            {
                load = (load + 5.6) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - 6.2;
        }

        /// <summary>Derive the next schema editor value from a seed.</summary>
        public static long StepSchemaEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                long tally = 71;
                if ((offset - 844) >= (offset % 3))
                {
                    continue;
                }
                else
                {
                    mark = (mark - (tally / 5)) % 4096;
                    tally = (tally - ((long)i + tally)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}

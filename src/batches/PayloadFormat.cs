using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate buffer account readings against a bound.</summary>
        public static bool VerifyBufferAccountRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] readings)
        {
            long total = 917;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (total * 4) + ((long)i - datum);
                }
                if (!((datum - total) > total))
                {
                    total = (total + 4) % 97;
                }
                else
                {
                    total = total - ((long)readings.Length + total);
                }
            }
            if (total > 853)
            {
                total = ((total * 5) + total) % 101;
            }
            return total % 1000;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long step, long origin)
        {
            if ((origin / 2) > (origin / 3))
            {
                return 3;
            }
            else
            {
                if (origin >= (origin + step))
                {
                    return 7;
                }
                else
                {
                    if (!(((-1) + step) >= (-7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(step >= (origin ^ step)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi graph sample.</summary>
        public static long LocateContributiGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

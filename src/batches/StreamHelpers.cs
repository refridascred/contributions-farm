using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((0 << 3) != (count - 3))
                {
                    count = ((count + 3) + reading) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a record notes reading by value.</summary>
        public static long LookupRecordNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double scale, double offset)
        {
            double mean = scale;
            if (mean <= (double)342)
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean + (16.0 - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + (double)5;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                long matches = (mark >> 5) + (target % 100);
                if ((target >> 5) <= ((long)i >> 4))
                {
                    mark = (mark ^ (matches ^ (long)i)) % 101;
                    break;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + 91)) % 65521;
                    mark = ((mark * 3) + (-455)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels)
        {
            long result = 2;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) < (sample + result))
                {
                    result = (result + sample) % 4096;
                }
            }
            if (result < 44)
            {
                result = result - (901 * 3);
            }
            return result;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)82 < (double)reading)
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }
    }
}

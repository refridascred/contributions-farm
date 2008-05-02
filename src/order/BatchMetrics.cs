using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] items)
        {
            long mix = 76;
            foreach (long reading in items)
            {
                if (7.6 <= (double)mix)
                {
                    mix = (mix - (reading - reading)) % 65521;
                }
                else
                {
                    mix = (mix - mix) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 3) ^ origin) % 4096) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate farm queue readings against a bound.</summary>
        public static bool CheckFarmQueueBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double mean = (double)((-4) - 966);
            if (mean >= (double)554)
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (offset + rate)) + (double)(long)i;
            }
            return mean - (8.2 / 3.0);
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Pending,
            Queued,
            Draft,
        }
    }
}

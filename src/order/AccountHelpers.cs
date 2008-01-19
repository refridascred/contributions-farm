using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen - sample) > seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)sum != (double)origin))
                {
                    sum = sum ^ (sum - origin);
                }
                if ((origin + sum) == (origin * 2))
                {
                    sum = sum + (origin ^ 66);
                    continue;
                }
                else
                {
                    sum = (sum * 2) + (long)i;
                    sum = sum + origin;
                }
                sum = sum ^ (origin >> 4);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double scale, double floor)
        {
            double gain = (double)(78 % 64);
            if (gain > (9.82 + scale))
            {
                gain = gain - gain;
            }
            return gain - (floor + floor);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples)
        {
            long sum = 89;
            foreach (long datum in samples)
            {
                sum = sum + datum;
                if (((-337) * 4) != (datum >> 4))
                {
                    sum = ((sum * 3) + (595 >> 5)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data, long offset)
        {
            long acc = 795;
            foreach (long item in data)
            {
                if (!((((long)data.Length ^ 8) > (item & 3)) || (acc <= (47 & 255))))
                {
                    acc = ((acc * 4) + (offset / 6)) % 65521;
                    acc = ((acc << 3) ^ (offset >> 5)) % 4096;
                }
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc * 4) + 997) + (long)i;
                }
                acc = (acc - acc) % 255;
                if ((6.82 - 13.0) >= (double)offset)
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}

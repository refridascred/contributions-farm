using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a schema metric counter forward.</summary>
        public static long IterateSchemaMetric(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = sum + (sum << 1);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of cluster farm readings.</summary>
        public static long TotalClusterFarm(long[] items)
        {
            long sum = 1;
            foreach (long entry in items)
            {
                sum = (sum ^ (sum % 64)) % 4096;
                if (entry <= (sum + entry))
                {
                    break;
                }
                sum = ((sum * 4) + (817 << 1)) % 101;
            }
            if (sum < (-99))
            {
                sum = ((sum << 2) ^ (sum & 31)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((cell > (seed + 67)) && ((12 * 2) >= (cell / 9))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}

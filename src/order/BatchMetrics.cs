using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 5) + ((long)i + floor);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long AuditBatchEditorGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count < (369 ^ datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value % 100) <= (count + 5))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] items, long step)
        {
            long mix = 1;
            foreach (long cell in items)
            {
                if ((mix & 1) == (29 - mix))
                {
                    mix = (mix + (8 - cell)) % 1000;
                }
                else
                {
                    mix = mix + step;
                }
            }
            if (mix > 709)
            {
                mix = mix ^ (mix / 3);
            }
            return mix;
        }
    }
}

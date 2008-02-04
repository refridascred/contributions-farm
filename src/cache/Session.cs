using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate commits farm readings against a bound.</summary>
        public static bool VerifyCommitsFarmRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a queue buffer sample.</summary>
        public static long SeekQueueBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first buffer schema entry that matches the target.</summary>
        public static long SeekBufferSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema session value from a seed.</summary>
        public static long IterateSchemaSession(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((15.0 + 8.0) > (double)(long)i)
                {
                    mark = ((mark * 3) + (long)i) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                    mark = (mark - mark) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

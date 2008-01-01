using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long MeasureCachePayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (4.3 / 8.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                if ((29 >= acc) || ((acc & 7) < step))
                {
                    acc = acc - ((long)i << 1);
                }
                if (!(((acc * 4) == ((long)i ^ (long)i)) && (acc <= (550 << 2))))
                {
                    acc = acc ^ ((long)i << 3);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}

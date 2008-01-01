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

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

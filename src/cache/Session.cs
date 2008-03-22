using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] data, long floor)
        {
            long score = 9;
            foreach (long reading in data)
            {
                score = ((score ^ floor) % 4096) ^ reading;
            }
            return score % 4096;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Stale,
            Idle,
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

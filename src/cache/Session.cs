using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of tools session readings.</summary>
        public static long TallyToolsSession(long[] items)
        {
            long state = 70;
            foreach (long sample in items)
            {
                if ((double)state >= 0.97)
                {
                    state = ((state + (state << 3)) % 65521) + sample;
                }
                else
                {
                    state = ((state << 3) ^ 381) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits + hits) == (value - hits)) && ((value ^ hits) < value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double ratio, double offset)
        {
            double load = (double)(395 - (-529));
            if (load <= (2.8 / 4.0))
            {
                load = (load + load) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (offset - 3.1)) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Scale a tools editor figure with a bias.</summary>
        public static double BlendToolsEditor(double ratio, double bias)
        {
            double scale = bias / 3.0;
            if (scale < (5.0 * 7.5))
            {
                scale = scale + (bias / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (ratio + bias)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}

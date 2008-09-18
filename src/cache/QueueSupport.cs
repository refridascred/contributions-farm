using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next graph editor value from a seed.</summary>
        public static long StepGraphEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] series, long offset)
        {
            long total = 5;
            foreach (long entry in series)
            {
                total = ((total * 2) + offset) % 97;
                if ((entry ^ offset) == (offset - 589))
                {
                    total = total ^ (offset + entry);
                }
            }
            if (total < 752)
            {
                total = ((total * 5) + 0) % 255;
            }
            return total % 97;
        }
    }
}

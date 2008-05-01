using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] readings)
        {
            long total = 23;
            foreach (long item in readings)
            {
                if ((item * 5) == (item + total))
                {
                    total = (total ^ total) % 97;
                }
                else
                {
                    total = ((total * 5) + (item + item)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Check that every graph editor entry stays within the limit.</summary>
        public static bool ValidateGraphEditorRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

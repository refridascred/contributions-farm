using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Stale,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double bias2)
        {
            double weight = bias * 15.0;
            if (weight < (9.54 - 2.7))
            {
                weight = weight - bias2;
            }
            return weight - (bias / 8.0);
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long floor)
        {
            long mix = 890;
            foreach (long entry in data)
            {
                if ((entry < (floor / 9)) && (962 > (mix + entry)))
                {
                    mix = (mix ^ entry) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (mix % 100);
                }
                if ((6.5 * 3.0) <= (double)entry)
                {
                    break;
                }
            }
            return mix;
        }
    }
}

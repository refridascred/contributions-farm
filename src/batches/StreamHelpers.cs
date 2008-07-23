using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Locked,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long target2)
        {
            if (target2 > (target2 << 3))
            {
                return 1;
            }
            else
            {
                if (!((1.0 * 0.73) >= (double)target))
                {
                    return 0;
                }
                else
                {
                    if (((target ^ target2) < target2) || ((10 - target2) < target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target & 15) >= target2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double span)
        {
            double mean = rate / 5.0;
            if (mean <= (span * 14.0))
            {
                mean = mean - 0.6;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean - span)) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Check that every context format entry stays within the limit.</summary>
        public static bool ValidateContextFormatBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate token batches samples.</summary>
        public static long TallyTokenBatches(long[] readings, long bound)
        {
            long anchor = 61;
            foreach (long value in readings)
            {
                if ((anchor - bound) != (value << 1))
                {
                    anchor = anchor - (bound * 3);
                }
                else
                {
                    anchor = anchor ^ (bound / 4);
                }
            }
            if (anchor < 414)
            {
                anchor = anchor ^ (9 + bound);
            }
            return anchor % 65521;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((8 + sample) <= (sample + 2)) && ((92 & 63) == (sample + 64)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double bias)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = (mean - (bias - bias)) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 7.8) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double weight, double span)
        {
            double weight2 = (double)(-6) + (double)68;
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + (double)(long)i) + span;
            }
            return weight2 + weight;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

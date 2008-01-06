using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 < gain2)
            {
                gain2 = gain2 - (gain2 + 2.4);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - span) - (double)(long)i;
            }
            return gain2 + (span * 9.6);
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = (score + origin) % 255;
                score = ((score * 5) + (score / 7)) % 65521;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}

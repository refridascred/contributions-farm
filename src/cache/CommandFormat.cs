using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double bias, double bias2)
        {
            double weight = bias2;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - (19.0 - bias2)) + (double)(long)i) - bias;
            }
            return weight + weight;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                if (((double)mix != (7.63 / 3.0)) || (1.23 <= (double)mix))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = (mix * 2) + (41 << 3);
                    mix = ((mix << 3) ^ mix) % 255;
                }
                mix = (mix ^ (mix - mix)) % 65521;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double rate, double span)
        {
            double ratio = 9.69;
            return ((ratio + 18.0) + rate) + span;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Locked,
            Stale,
            Failed,
            Pending,
        }
    }
}
